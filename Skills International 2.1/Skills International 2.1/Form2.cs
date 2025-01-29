using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International_2._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ////////////////////////////////////
            ///


            try
            {
                // Validate regno (Registration Number)

                /*if (string.IsNullOrWhiteSpace(comboBox1.Text) || !int.TryParse(comboBox1.Text, out int regno))
                {
                    MessageBox.Show("Invalid Registration Number. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/

                // Establish the SQL connection
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S7IKCNB\SQLEXPRESS;Initial Catalog=""Skills International 2.1"";Integrated Security=True;Encrypt=False");
                conn.Open();



                // Create the SQL command
                SqlCommand cnn = new SqlCommand("Insert into Registration VALUES (@reg_no, @f_name, @l_name, @dob, @gender, @address, @email, @s_mobile, @p_name, @p_nic, @p_mobile)", conn);

                // Add parameters
                // cnn.Parameters.AddWithValue("@regno", textBox9.Text); // Already validated as numeric
                cnn.Parameters.AddWithValue("@reg_no", textBox9.Text);
                cnn.Parameters.AddWithValue("@f_name", textBox1.Text);
                cnn.Parameters.AddWithValue("@l_name", textBox2.Text);
                cnn.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cnn.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female");
                cnn.Parameters.AddWithValue("@address", textBox4.Text);
                cnn.Parameters.AddWithValue("@email", textBox3.Text);
                cnn.Parameters.AddWithValue("@s_mobile", textBox5.Text);
                cnn.Parameters.AddWithValue("@p_name", textBox8.Text);
                cnn.Parameters.AddWithValue("@p_nic", textBox7.Text);
                cnn.Parameters.AddWithValue("@p_mobile", textBox6.Text);

                // Execute the command
                cnn.ExecuteNonQuery();



                MessageBox.Show("Registration Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                ////////////////////////////


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();


        }

        private void button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are You Want to Exit", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Stop); 
            Application.Exit();
            //MessageBox.Show("Are You Want to Exit", "Update",MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate regno (Registration Number)

                /*if (string.IsNullOrWhiteSpace(comboBox1.Text) || !int.TryParse(comboBox1.Text, out int regno))
                {
                    MessageBox.Show("Invalid Registration Number. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/

                // Establish the SQL connection
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S7IKCNB\SQLEXPRESS;Initial Catalog=""Skills International 2.1"";Integrated Security=True;Encrypt=False");
                conn.Open();



                // Create the SQL command
                SqlCommand cnn = new SqlCommand("update Registration set f_name=@f_name, l_name=@l_name, dob=@dob, gender=@gender, address=@address, email=@email, s_mobile=@s_mobile, p_name=@p_name, p_nic=@p_nic, p_mobile=@p_mobile where reg_no=@reg_no", conn);

                // Add parameters
                // cnn.Parameters.AddWithValue("@regno", textBox9.Text); // Already validated as numeric
                cnn.Parameters.AddWithValue("@reg_no", textBox9.Text);
                cnn.Parameters.AddWithValue("@f_name", textBox1.Text);
                cnn.Parameters.AddWithValue("@l_name", textBox2.Text);
                cnn.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cnn.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female");
                cnn.Parameters.AddWithValue("@address", textBox4.Text);
                cnn.Parameters.AddWithValue("@email", textBox3.Text);
                cnn.Parameters.AddWithValue("@s_mobile", textBox5.Text);
                cnn.Parameters.AddWithValue("@p_name", textBox8.Text);
                cnn.Parameters.AddWithValue("@p_nic", textBox7.Text);
                cnn.Parameters.AddWithValue("@p_mobile", textBox6.Text);

                // Execute the command
                cnn.ExecuteNonQuery();



                MessageBox.Show("Update Successful", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate regno (Registration Number)

                /*if (string.IsNullOrWhiteSpace(comboBox1.Text) || !int.TryParse(comboBox1.Text, out int regno))
                {
                    MessageBox.Show("Invalid Registration Number. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }*/


                // Establish the SQL connection
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S7IKCNB\SQLEXPRESS;Initial Catalog=""Skills International 2.1"";Integrated Security=True;Encrypt=False");
                conn.Open();



                // Create the SQL command
                SqlCommand cnn = new SqlCommand("delete Registration where reg_no=@reg_no ", conn);

                // Add parameters
                // cnn.Parameters.AddWithValue("@regno", textBox9.Text); // Already validated as numeric

                cnn.Parameters.AddWithValue("@reg_no", textBox9.Text);

                // Execute the command
                cnn.ExecuteNonQuery();



                MessageBox.Show("Recode Deleted Successful", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
