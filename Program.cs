// See https://aka.ms/new-console-template for more information
using Ninject;    


IKernel kernel = new StandardKernel();
kernel.Bind<IResultService>().To<ResultService>();
kernel.Bind<StudentService>().ToSelf();

var studentService = kernel.Get<StudentService>();
studentService.GetStudentResult();

// IResultService resultService = new TestResultService();
// StudentService _studentService = new StudentService(resultService);
// _studentService.GetStudentResult();



