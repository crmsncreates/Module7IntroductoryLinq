using System.ComponentModel;
namespace Module7IntroductoryLinq;

public partial class Form1 : Form
{
    List<Student> records = [];

    public Form1()
    {
        InitializeComponent();

        ResetStudents();
    }

    void ResetStudents()
    {
        records.Clear();
        LoadStudents();
        RefreshStudents();
    }

    void LoadStudents()
    {
        records.Add(new()
        {
            StudentId = 0,
            FirstName = "Gordon",
            LastName = "Freeman",
            GPA = 3.9,
        });
        records.Add(new()
        {
            StudentId = 1,
            FirstName = "Fred",
            LastName = "Bloggs",
            GPA = 3.8,
        });
        records.Add(new()
        {
            StudentId = 25,
            FirstName = "Joe",
            LastName = "Bloggs",
            GPA = 3.6,
        });
        records.Add(new()
        {
            StudentId = 34,
            FirstName = "John",
            LastName = "Smith",
            GPA = 2.3,
        });
        records.Add(new()
        {
            StudentId = 413,
            FirstName = "Alice",
            LastName = "Surname",
            GPA = 3.5,
        });
        records.Add(new()
        {
            StudentId = 268,
            FirstName = "Miles",
            LastName = "Prower",
            GPA = 4.0,
        });
        records.Add(new()
        {
            StudentId = 512,
            FirstName = "John",
            LastName = "Doe",
            GPA = 2.11,
        });
        records.Add(new()
        {
            StudentId = 782,
            FirstName = "Porky",
            LastName = "Minch",
            GPA = 1.22,
        });
        records.Add(new()
        {
            StudentId = 1024,
            FirstName = "Flandre",
            LastName = "Scarlet",
            GPA = 2.34,
        });
        records.Add(new()
        {
            StudentId = 1234,
            FirstName = "Hugh",
            LastName = "Mann",
            GPA = 3.24,
        });
    }

    void RefreshStudents()
    {
        dgvStudents.DataSource = null;
        dgvStudents.DataSource = records;
        lblResultCount.Text = $"Results: {records.Count} matching students";
        lblAverageGPA.Text = $"Average GPA: {records.Average(x => x.GPA):0.00}";
    }

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        ResetStudents();
    }

    private void btnFilterProgram_Click(object sender, EventArgs e)
    {
        records = [..records.Where(x => x.ProgramName.Contains(txtProgram.Text))];
        RefreshStudents();
    }

    private void btnFilterGPA_Click(object sender, EventArgs e)
    {
        records = [..records.Where(x => x.GPA >= (double)nudGPA.Value)];
        RefreshStudents();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var query = txtStudentIdOrName.Text.Trim();
        records = [..
            records.Where(x =>
                x.StudentId.ToString() == query
                || x.FirstName.Contains(query)
                || x.LastName.Contains(query)
            )
        ];
        RefreshStudents();
    }

    private void btnSortByLastName_Click(object sender, EventArgs e)
    {
        records = [.. records.OrderBy(x => x.LastName)];
        RefreshStudents();
    }

    private void btnSortByGPA_Click(object sender, EventArgs e)
    {
        records = [.. records.OrderBy(x => x.GPA)];
        RefreshStudents();
    }
}
