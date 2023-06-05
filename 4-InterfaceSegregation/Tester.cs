using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation
{
    public class 
        Tester : 
        ITestActivities, 
        IWorkTeamActivities
    {
        public Tester()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Test() 
        {
            throw new ArgumentException();
        }
    }
}