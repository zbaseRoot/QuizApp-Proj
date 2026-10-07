namespace Network
{
    public class ResultPacket
    {
        public bool IsCorrect { get; set; }
        public int AddedPoints { get; set; }
        public int TotalScore { get; set; }
        public string CorrectOptionText { get; set; }
    }
}
