namespace CaliburnAutoFac.ViewModels
{
    public class SampleOneViewModel : IChildSampleViewModel
    {
        public string DisplayName { get; } = "Sample One";
        public string Message { get; } = "This is the first sample.";
    }
}