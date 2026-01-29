namespace FindShaulsTreasure.Quests.Group_00;

public partial class Quest_00 : BaseQuestView
{
	public Quest_00(int teamId) : base(teamId)
	{
		Data = new Models.QuestInfo("Example Quest", "Example Hint", "Example Anwser");

		InitializeComponent();

		lTeam.Text = "Current Team: " + TeamNumber.ToString();
	}
}