using System;using R5T.T0064;


namespace R5T.Mullingar
{[ServiceDefinitionMarker]
    public interface IHelloWorldMessageProvider:IServiceDefinition
    {
        string GetHelloWorldMessage();
    }
}
