using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation
{
    public interface IActivities : IWorkTeamActivities, IDevelopActivities, IDesignActivities, ITestActivities, ISegurityActivities
    {

    }
}