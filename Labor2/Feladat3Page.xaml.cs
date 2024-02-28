namespace Labor2;

public partial class Feladat3Page : ContentPage
{
    List<Student> students = new List<Student>();
    public Feladat3Page()
    {
        InitializeComponent();

        students.Add(new Student(10, "Bob", "Smith", 80.5));
        students.Add(new Student(25, "James", "Brown", 77.9));
        students.Add(new Student(15, "Joe", "Martin", 52.4));
        students.Add(new Student(12, "Dona", "Taylor", 53.6));
        students.Add(new Student(18, "Peter", "Brian", 90.9));

        adatok.ItemsSource = students;
    }
}