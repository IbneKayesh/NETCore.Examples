namespace NETCore.DependencyInjector.Services
{
    public interface IPOSFactory
    {
        IPOSService Create(string creatureType);
    }
}
