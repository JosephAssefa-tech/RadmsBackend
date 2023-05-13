namespace RadmsWebAPI.Response
{
    public class TrendAnalysisResponse
    {

        public int Year { get; set; }
        public int FatalCount {get;set;}
        public int SeriousCount {get;set;}
        public int SlightCount {get;set;}
        public int PropertyDamageCount {get;set;}
        public TrendAnalysisResponse()
        {

        }

    }
}
