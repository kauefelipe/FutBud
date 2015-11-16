using System.ServiceModel;
using System.ServiceModel.Channels;

namespace FutBud.WCF_Stuff
{
	public class MyServiceClient : ClientBase<InterfaceWcfService>, InterfaceWcfService
	{
        public MyServiceClient(Binding binding, EndpointAddress address)
            : base(binding, address)
        {
        }

		public string Execute ()
		{
		    return Channel.Execute();
		}
	}
}