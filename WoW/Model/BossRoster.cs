namespace WoW.Model
{
    public class BossRoster
    {
        public int RosterId { get; set; }
        public List<Member> Participants { get; set; } = new List<Member>();
        public string BossName { get; set; }
        public DateTime Date { get; set; }
    }
}
