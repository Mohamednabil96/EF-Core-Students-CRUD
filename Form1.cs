using Task_Day_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_Day_2
{
    public partial class Form1 : Form
    {
        ITIContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ITIContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, SuperName = n.St_superNavigation.St_Fname, department = n.Dept.Dept_Name }).ToList();

            btnUpdate.Visible = false;
            btnDelete.Visible = false;


            comboDept.DataSource = db.Departments.ToList();
            comboDept.DisplayMember = "Dept_Name";
            comboDept.ValueMember = "Dept_Id";


            comboSuper.DataSource = db.Students.ToList();
            comboSuper.DisplayMember = "St_Fname";
            comboSuper.ValueMember = "St_Id";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                St_Fname = txtFName.Text,
                St_Lname = txtLName.Text,
                St_Age = int.Parse(txtAge.Text),
                St_Address = txtAddress.Text,
                St_super = (int)comboSuper.SelectedValue,
                Dept_Id = (int)comboDept.SelectedValue,

            };

            db.Add(s);
            db.SaveChanges();

            txtFName.Text = txtLName.Text = txtAge.Text = txtAddress.Text = " ";

            lbl_status.Text = "Student Added";

            dgvStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, SuperName = n.St_superNavigation.St_Fname, department = n.Dept.Dept_Name }).ToList();
        }

        int id;

        private void dgvStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgvStudents.SelectedRows[0].Cells[0].Value;

            Student s = db.Students.Where(m => m.St_Id == id).SingleOrDefault();

            txtFName.Text = s.St_Fname;
            txtLName.Text = s.St_Lname;
            txtAge.Text = s.St_Age.ToString();
            txtAddress.Text = s.St_Address;

            comboDept.SelectedValue = s.Dept_Id != null ? s.Dept_Id : "";
            comboSuper.SelectedValue = s.St_super != null ? s.St_super : "";


            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(m => m.St_Id == id).SingleOrDefault();

            s.St_Fname = txtFName.Text;
            s.St_Lname = txtLName.Text;
            s.St_Age = int.Parse(txtAge.Text);
            s.St_Address = txtAddress.Text;

            s.Dept_Id = (int)comboDept.SelectedValue;
            s.St_super = (int)comboSuper.SelectedValue;

            txtFName.Text = txtLName.Text = txtAge.Text = txtAddress.Text = " ";

            lbl_status.Text = "Student Updated";

            db.SaveChanges();
            dgvStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, SuperName = n.St_superNavigation.St_Fname, department = n.Dept.Dept_Name }).ToList();


            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ??", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Student s = db.Students.Where(m => m.St_Id == id).SingleOrDefault();


                db.Students.Remove(s);

                db.SaveChanges();

                txtFName.Text = txtLName.Text = txtAge.Text = txtAddress.Text = " ";


                dgvStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, SuperName = n.St_superNavigation.St_Fname, department = n.Dept.Dept_Name }).ToList();

                lbl_status.Text = "Student Deleted";

                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }

        }




    }
}