namespace WinWin.Models;

public class EventModel
{
    public EventModel(TeamModel teamA, TeamModel teamB, DateTime scheduleDateTime, int teamAScore, int teamBScore)
    {
        TeamA = teamA ?? throw new ArgumentNullException(nameof(teamA));
        TeamB = teamB ?? throw new ArgumentNullException(nameof(teamB));
        ScheduleDateTime = scheduleDateTime;
        TeamAScore = teamAScore;
        TeamBScore = teamBScore;
    }

    private TeamModel TeamA { get; set; }
    private TeamModel TeamB { get; set; }
    private DateTime ScheduleDateTime { get; set; }
    private int TeamAScore { get; set; }
    private int TeamBScore { get; set; }
}