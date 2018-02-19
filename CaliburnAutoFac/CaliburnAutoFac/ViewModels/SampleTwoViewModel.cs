namespace CaliburnAutoFac.ViewModels
{
    public class SampleTwoViewModel : IChildSampleViewModel
    {
        public string DisplayName { get; } = "IoC Container";
        public string Message { get; } = "AutoFac";
    }
}