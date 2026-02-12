namespace FindShaulsTreasure.Pages;

public partial class QuestHolder : ContentPage
{
	int currentTeamId = 5;


	public QuestHolder()
	{
		InitializeComponent();

		var firstQuest = new Quests.Group_05.Quest_05(currentTeamId);

		cvCurrentQuest.Content = firstQuest;

		lQuestName.Text = firstQuest.Data.QuestName;
	}
}