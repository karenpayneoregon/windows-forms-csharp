using System.Collections.ObjectModel;

namespace MasterDetail
{
    public class LeagueList : ObservableCollection<League>
    {
        public LeagueList()
        {
            League league;
            Division division;

            Add(league = new League("League A"));
            league.Divisions.Add(division = new Division("Division A"));
            division.Teams.Add(new Team("Team I"));
            division.Teams.Add(new Team("Team II"));
            division.Teams.Add(new Team("Team III"));
            division.Teams.Add(new Team("Team IV"));
            division.Teams.Add(new Team("Team V"));
            league.Divisions.Add(division = new Division("Division B"));
            division.Teams.Add(new Team("Team Blue"));
            division.Teams.Add(new Team("Team Red"));
            division.Teams.Add(new Team("Team Yellow"));
            division.Teams.Add(new Team("Team Green"));
            division.Teams.Add(new Team("Team Orange"));
            league.Divisions.Add(division = new Division("Division C"));
            division.Teams.Add(new Team("Team East"));
            division.Teams.Add(new Team("Team West"));
            division.Teams.Add(new Team("Team North"));
            division.Teams.Add(new Team("Team South"));
            Add(league = new League("League B"));
            league.Divisions.Add(division = new Division("Division A"));
            division.Teams.Add(new Team("Team 1"));
            division.Teams.Add(new Team("Team 2"));
            division.Teams.Add(new Team("Team 3"));
            division.Teams.Add(new Team("Team 4"));
            division.Teams.Add(new Team("Team 5"));
            league.Divisions.Add(division = new Division("Division B"));
            division.Teams.Add(new Team("Team Diamond"));
            division.Teams.Add(new Team("Team Heart"));
            division.Teams.Add(new Team("Team Club"));
            division.Teams.Add(new Team("Team Spade"));
            league.Divisions.Add(division = new Division("Division C"));
            division.Teams.Add(new Team("Team Alpha"));
            division.Teams.Add(new Team("Team Beta"));
            division.Teams.Add(new Team("Team Gamma"));
            division.Teams.Add(new Team("Team Delta"));
            division.Teams.Add(new Team("Team Epsilon"));
        }
    }
}