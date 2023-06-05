using Microsoft.AspNetCore.Mvc;
using static DependencyInversion.Logbook;
using static DependencyInversion.StudentRepository;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    //old
    //StudentRepository studentRepository = new StudentRepository();
    //Logbook logbook = new Logbook();

    /**************[Injectar Dependecia]**************/
    //Declarando Interfaces
    IStudentRepository studentRepository;
    ILogbook logbook;

    public StudentController(
        IStudentRepository _IStudentRepository,
        ILogbook _ILogbook
    ) { 
        studentRepository = _IStudentRepository;
        logbook = _ILogbook;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
