namespace FindShaulsTreasure.Quests;

public partial class BaseQuestView : ContentView
{
    public Models.QuestInfo Data { get; protected set; } = null!;
    public int TeamNumber { get; private set; }

    public BaseQuestView(int teadId)
	{
		this.TeamNumber = teadId;
	}
}