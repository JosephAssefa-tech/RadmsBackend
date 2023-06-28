namespace RadmsWebAPI.Response
{
    public class DashboardResponse
    {
        public int TotalAccidentCount { get; set; }
        public int TotalPropertyDamage { get; set; }
        public int DashboardTotalPropertyDamage { get; set; }
        public int blackspotCount { get; set; }

        public DashboardResponse()
        {

        }
    }
 
}
