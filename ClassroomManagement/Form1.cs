using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace ClassroomManagement
{
    public partial class Form1 : Form
    {

        String file_path = "";

        List<Student> sorted_student_list = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file_path = openFileDialog.FileName;
                    String[] all_record;

                    all_record = File.ReadAllLines(file_path);


                    if (classroom_gridview.Rows.Count == 1)
                    {
                        //add rows
                        for (int i = 0; i < 18; i++)
                        {
                            classroom_gridview.Rows.Add();
                        }
                        //add numbers in header
                        for (int i = 0; i < classroom_gridview.Rows.Count; i++)
                        {
                            classroom_gridview.Rows[i].HeaderCell.Value = i.ToString();
                        }

                    }



                    teacher_textbox.Text = all_record[0].Split(',')[1];
                    class_textbox.Text = all_record[1].Split(',')[1];
                    room_textbox.Text = all_record[2].Split(',')[1];
                    date_textbox.Text = all_record[3].Split(',')[1];

                    for (int i = 4; i < all_record.Length; i++)
                    {
                        // add data to each cell
                        if (all_record[i].Split(',').Length == 4 && all_record[i].Split(',')[3] == "blue")
                        {
                            classroom_gridview[Int32.Parse(all_record[i].Split(',')[0]), Int32.
                                Parse(all_record[i].Split(',')[1])].Style.BackColor = Color.LightBlue;

                        }
                        else
                        {
                            classroom_gridview[Int32.Parse(all_record[i].Split(',')[0]), Int32.
                                Parse(all_record[i].Split(',')[1])].Value = all_record[i].Split(',')[2];


                        }



                    }

                }





            }


        }




        private void clear_button_Click_1(object sender, EventArgs e)
        {
            file_check();


            for (int i = 1; i < classroom_gridview.Rows.Count; i++)
            {
                for (int t = 0; t < classroom_gridview.Columns.Count; t++)
                {
                    if (classroom_gridview[t, i].Value != null)
                    {
                        classroom_gridview[t, i].Value = null;
                    }
                }
            }

        }

        private void save_change_button_Click(object sender, EventArgs e)
        {
            file_check();
            save_change();

        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            file_check();
            sort_by_name();
            MessageBox.Show("Student listing sorted alphabetically!", "Student Listing Sorted!", MessageBoxButtons.OK);

        }




        public void sort_by_name()
        {

            sorted_student_list = new List<Student>();


            for (int i = 1; i < classroom_gridview.Rows.Count; i++)
            {
                for (int t = 0; t < classroom_gridview.Columns.Count; t++)
                {
                    if (classroom_gridview[t, i].Value != null)
                    {


                        Student instance_student = new Student();
                        instance_student.Column = t;
                        instance_student.Row = i;
                        instance_student.Name = classroom_gridview[t, i].Value.ToString();

                        sorted_student_list.Add(instance_student);



                    }
                }
            }

            sorted_student_list.Sort();


        }

        private void find_button_Click(object sender, EventArgs e)
        {
            file_check();

            String targeted_name = find_textfield.Text;
            if (targeted_name == "")
            {
                MessageBox.Show("Please input a name.", "Name is blank", MessageBoxButtons.OK);
                return;
            }



            if (sorted_student_list == null)
            {
                sort_by_name();
            }

            int search_result = binary_search(targeted_name);

            if (search_result == -1)
            {
                MessageBox.Show("Sorry, no name was found for " + targeted_name, "NOT FOUND", MessageBoxButtons.OK);

                return;

            }
            else
            {

                String all_student_text = "Student\t\t" + "Row\t" + "Col\t" + "\n";

                for (int i = 0; i < sorted_student_list.Count; i++)
                {
                    all_student_text += sorted_student_list[i].Name + "\t\t"
                            + sorted_student_list[i].Row.ToString() + "\t" + sorted_student_list[i].Column.ToString() + "\t";


                    if (i == search_result)
                    {

                        all_student_text += "<-FOUND" + "\n";

                    }
                    else
                    {

                        all_student_text += "\n";

                    }

                }



                MessageBox.Show(all_student_text, "Student List - Search: " + targeted_name, MessageBoxButtons.OK);

                return;



            }

        }

        private void save_raf_button_Click(object sender, EventArgs e)
        {
            file_check();

            String raf_data = "";

            raf_data += "Teacher:" + "," + teacher_textbox.Text + "\n";
            raf_data += "Class:" + "," + class_textbox.Text + "\n";
            raf_data += "Room:" + "," + teacher_textbox.Text + "\n";
            raf_data += "Date:" + "," + date_textbox.Text + "\n";


            for (int i = 0; i < classroom_gridview.Rows.Count; i++)
            {
                for (int t = 0; t < classroom_gridview.Columns.Count; t++)
                {
                    if (classroom_gridview[t, i].Style.BackColor == Color.LightBlue)
                    {
                        raf_data += t + "," + i + "," + "BKGRND FILL,blue";


                    }
                    else if (classroom_gridview[t, i].Value != null)
                    {
                        raf_data += t + "," + i + "," + classroom_gridview[t, i].Value;
                    }

                }
            }







            var fileName = @"binaryData.dat";
            var writer = new BinaryWriter(new FileStream(fileName, FileMode.Create));

            writer.Write(raf_data);

            writer.Close();

            MessageBox.Show("Classroom data successfully written to random access file binaryData.dat", "SUCCESS - Random Access File written!", MessageBoxButtons.OK);








        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            exit_app();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_check();

            save_change();

        }

       
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_check();


            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".csv";
            saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = saveFileDialog.FileName;


                List<String> save_list = new List<String>();

                String new_teacher_info = "Teacher:" + "," + teacher_textbox.Text;
                String new_class_info = "Class:" + "," + class_textbox.Text;
                String new_room_info = "Room:" + "," + teacher_textbox.Text;
                String new_date_info = "Date:" + "," + date_textbox.Text;

                save_list.Add(new_teacher_info);
                save_list.Add(new_class_info);
                save_list.Add(new_room_info);
                save_list.Add(new_date_info);

                String new_cell_info;

                for (int i = 0; i < classroom_gridview.Rows.Count; i++)
                {
                    for (int t = 0; t < classroom_gridview.Columns.Count; t++)
                    {
                        if (classroom_gridview[t, i].Style.BackColor == Color.LightBlue)
                        {
                            new_cell_info = t + "," + i + "," + "BKGRND FILL,blue";
                            save_list.Add(new_cell_info);
                        }
                        else if (classroom_gridview[t, i].Value != null)
                        {
                            new_cell_info = t + "," + i + "," + classroom_gridview[t, i].Value;
                            save_list.Add(new_cell_info);
                        }

                    }
                }


                //StreamWriter chosen_file = new StreamWriter(file_path, false, Encoding.UTF8);

                File.WriteAllLines(file_path, save_list.ToArray());

                MessageBox.Show("Class data update saved to" + file_path, "FILE SAVE SUCCESSFUL!", MessageBoxButtons.OK);


            }





        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_app();
        }


        //save method
        public void save_change()
        {

            List<String> save_list = new List<String>();

            String new_teacher_info = "Teacher:" + "," + teacher_textbox.Text;
            String new_class_info = "Class:" + "," + class_textbox.Text;
            String new_room_info = "Room:" + "," + teacher_textbox.Text;
            String new_date_info = "Date:" + "," + date_textbox.Text;

            save_list.Add(new_teacher_info);
            save_list.Add(new_class_info);
            save_list.Add(new_room_info);
            save_list.Add(new_date_info);

            String new_cell_info;

            for (int i = 0; i < classroom_gridview.Rows.Count; i++)
            {
                for (int t = 0; t < classroom_gridview.Columns.Count; t++)
                {
                    if (classroom_gridview[t, i].Style.BackColor == Color.LightBlue)
                    {
                        new_cell_info = t + "," + i + "," + "BKGRND FILL,blue";
                        save_list.Add(new_cell_info);
                    }
                    else if (classroom_gridview[t, i].Value != null)
                    {
                        new_cell_info = t + "," + i + "," + classroom_gridview[t, i].Value;
                        save_list.Add(new_cell_info);
                    }

                }
            }


            //StreamWriter chosen_file = new StreamWriter(file_path, false, Encoding.UTF8);

            File.WriteAllLines(file_path, save_list.ToArray());

            MessageBox.Show("Class data update saved to" + file_path, "FILE SAVE SUCCESSFUL!", MessageBoxButtons.OK);


        }

        //exit method
        public void exit_app()
        {
            if (MessageBox.Show("Will you exit this program?", "EXIT OPTIONS",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        public void file_check()
        {
            if (classroom_gridview.Rows.Count == 1)
            {
                MessageBox.Show("Please choose a file.", "No data", MessageBoxButtons.OK);
                return;

            }
        }

        /// <summary>
        /// binary search method
        /// </summary>
        /// <param name="targeted_name"></param>
        /// <returns></returns>
        public int binary_search(string targeted_name)
        {

            // binary search
            int Min = 0;
            int Max = sorted_student_list.Count - 1;

            while (true)
            {


                if (String.Compare(targeted_name, sorted_student_list[Min + ((Max - Min) / 2)].Name, true) == 0)
                {
                    return Min + (Max - Min) / 2;

                }

                else if (Max == Min)
                {
                    //if the number of data is only one and it's diffrent, then not fount and return


                    return -1;
                }



                else if (String.Compare(targeted_name, sorted_student_list[Min + ((Max - Min) / 2)].Name, true) == -1)
                {
                    Max -= (((Max - Min) / 2) + 1);
                }
                else
                {

                    Min += (((Max - Min) / 2) + 1);

                }




            }










        }











    }
}

