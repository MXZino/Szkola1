using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzkolaBartoszGulatowski
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        School school = new School();
        public MainWindow()
        {
            InitializeComponent();
            School school = new School();
            
        }
        //Przycisk dodawania klasy
        private void AddAClassButton_Click(object sender, RoutedEventArgs e)
        {
            using (AddNewClassForm form = new AddNewClassForm())
            {
                bool a = true;
                while (a)
                {
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        if (CheckName(form.text))
                        {
                            Class class1 = new Class(form.text);
                            school.AddAClass(class1);
                            ClassListBox.Items.Add(form.text);
                            SelectClass.Items.Add(form.text);
                            SelectClass2.Items.Add(form.text);
                            SelectClass3.Items.Add(form.text);
                            a = false;
                        }
                        else
                            MessageBox.Show("Klasa o takiej nazwie już istnieje");
                    }
                }              
            }
            
        }
        //Funkcja sprawdzająca, czy klasa o danej nazwie juz istnieje
        public bool CheckName(string text)
        {
            for (int i=0; i < school.Classes.Count(); i++)
            {
                if (school.Classes[i].GetName() == text)
                {
                    return false;                    
                }
            }
            return true;

        }
        //Przycisk dodawania nauczyciela

        private void AddATeacher_Click(object sender, RoutedEventArgs e)
        {
            using (AddNewTeacherForm form = new AddNewTeacherForm())
            {
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        Teacher teacher = new Teacher(form.firstName, form.secondName);
                        school.Classes[SelectClass.SelectedIndex].AddATeacher(teacher);
                        UpdateTeacher();
                        UpdateTeacher2();
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Nie wybrałeś elementu, bądź nie dodałeś klas/nauczycieli!");
                    }
                }
            }
        }

        private void SelectClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTeacher();
        }
        
        //Funkcja, która aktualizuje listę nauczycieli z zakładki "Nauczyciele"
        public void UpdateTeacher()
        {
            TeacherListBox.Items.Clear();
            for(int i=0; i < school.Classes[SelectClass.SelectedIndex].TeachersCount(); i++)
            {
                TeacherListBox.Items.Add(school.Classes[SelectClass.SelectedIndex].GetTeacher(i).GetFirstName() + " " + school.Classes[SelectClass.SelectedIndex].GetTeacher(i).GetSecondName());
            }
        }

        private void SelectClass2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTeacher2();
        }

        //Funkcja aktualizująca ComboBox z zakładki przedmioty
        public void UpdateTeacher2()
        {
            SelectTeacher.Items.Clear();
            for (int i = 0; i < school.Classes[SelectClass2.SelectedIndex].TeachersCount(); i++)
            {
                SelectTeacher.Items.Add(school.Classes[SelectClass2.SelectedIndex].GetTeacher(i).GetFirstName() + " " + school.Classes[SelectClass2.SelectedIndex].GetTeacher(i).GetSecondName());
            }
            SelectTeacher.SelectedIndex = 0;
        }

        //Przycisk dodawania przedmiotu
        private void AddASubjectButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryItems())
            {
                using (AddNewSubject form = new AddNewSubject())
                {
                    if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        Subject subject = new Subject(form.name, form.v1, form.v2);
                        school.Classes[SelectClass2.SelectedIndex].GetTeacher(SelectTeacher.SelectedIndex).AddASubject(subject);
                    }
                    UpdateSubjects();
                }
            }
            
        }

        //Dodawanie przedmiotów do ListBoxa
        public void UpdateSubjects()
        {
            
            for (int i = 0; i < school.Classes[SelectClass2.SelectedIndex].GetTeacher(SelectTeacher.SelectedIndex).SubjectsCount(); i++)
            {
                SubjectList.Items.Add("Nauczyciel: "+ SelectTeacher.SelectedValue.ToString() + " Klasa: " + SelectClass2.SelectedValue.ToString() + " " + school.Classes[SelectClass2.SelectedIndex].GetTeacher(SelectTeacher.SelectedIndex).GetSubject(i));
                
            }
        }

        //Przycisk dodawania ucznia
        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            if ((!String.IsNullOrEmpty(firstName.Text)) && (!String.IsNullOrEmpty(secondName.Text)))
            {
                Student student = new Student(firstName.Text, secondName.Text, school.Classes[SelectClass3.SelectedIndex]);
                school.AddAStudent(student);
                int temp = 0;
                for(int i=0; i < school.Students.Count; i++)
                {
                    if (school.Students[school.Students.Count - 1].GetClassname().GetName() == school.Students[i].GetClassname().GetName())
                        temp++;
                }
                school.Students[school.Students.Count - 1].SetId(temp);
                UpdateStudents();
            }
            else MessageBox.Show("Podaj poprawne dane!");
                           
        }

        //Aktualizacja listy uczniów w Listboź w zakładce "Uczniowie"
        public void UpdateStudents()
        {
            StudentList.Items.Clear();
            for (int i = 0; i < school.Students.Count; i++)
            {
                StudentList.Items.Add(school.Students[i]);
            }
        }


        //Funkcja zabezpieczająca błędy w zakładce przedmioty
        public bool TryItems()
        {
            if (SelectClass2.Items.Count == 0 || SelectTeacher.Items.Count == 0)
            {
                MessageBox.Show("Nie wybrałeś elementu, bądź nie dodałeś klas/nauczycieli!");
                return false;
            }
            else
                return true;
        }

       
    }
}
