using System.ServiceModel;

namespace FutBud.WCF_Stuff
{
	[ServiceContract]
	public interface InterfaceWcfService
	{
		[OperationContract]
		string Execute ();
	}
}
