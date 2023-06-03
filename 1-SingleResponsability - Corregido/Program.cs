using SingleResponsability;

StudentRepository studentRepository = new();

ExportHelper exportHelper = new();
exportHelper.ExportStudentsCSV(studentRepository.GetAll());

ExportHelperGeneric<Student> exportHelperGeneric = new();
exportHelperGeneric.ExportToCSV_v1(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");