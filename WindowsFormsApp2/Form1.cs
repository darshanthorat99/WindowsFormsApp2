using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {

            try
            {
                fs = new FileStream(@"D:\Tesla\depts.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept.Deptid = Convert.ToInt32(txtid.Text);
                dept.Deptname = txtname.Text;
                dept.Location = txtlocation.Text;
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\depts.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept = (Department)binaryFormatter.Deserialize(fs);
                txtid.Text = dept.Deptid.ToString();
                txtname.Text = dept.Deptname;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnxmlwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept.Deptid = Convert.ToInt32(txtid.Text);
                dept.Deptname = txtname.Text;
                dept.Location = txtlocation.Text;
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnxmlread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept = (Department)xmlSerializer.Deserialize(fs);
                txtid.Text = dept.Deptid.ToString();
                txtname.Text = dept.Deptname;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnsopawrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Department dept = new Department();
                dept.Deptid = Convert.ToInt32(txtid.Text);
                dept.Deptname = txtname.Text;
                dept.Location = txtlocation.Text;
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }



        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Deptid = Convert.ToInt32(txtid.Text);
                dept.Deptname = txtname.Text;
                dept.Location = txtlocation.Text;
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
              

        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtid.Text = dept.Deptid.ToString();
                txtname.Text = dept.Deptname;
                txtlocation.Text = dept.Location;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }
    }
}
