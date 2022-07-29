
namespace SKS
{
    public static class AppExtensions
    {
        public static ExtApplication ExtApp(this Mobilize.WebMap.Common.DCP.IApplication app) => app as ExtApplication;
        public static ExtApplication ExtApp(this object obj) => Mobilize.Web.Application.CurrentApplication as ExtApplication;
    }
}

