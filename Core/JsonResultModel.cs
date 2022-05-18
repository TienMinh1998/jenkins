namespace jenkinpipeline.Core
{
    public class JsonResultModel
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }         
    }
}