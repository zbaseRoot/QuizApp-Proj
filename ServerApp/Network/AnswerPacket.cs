namespace Network
{
    public class AnswerPacket
    {
        public int QuestionId { get; set; }
        public string SelectedOption { get; set; }
        public double TimeSpentSeconds { get; set; }
    }
}
