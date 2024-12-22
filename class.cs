using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace werewolf_öğrendik_artık
{
    public enum Role
    {
        Villager,
        Werewolf,
        Seer,
        Doctor,
        Veteran,
        Witch,
        Jester,

    }

    public class Player
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public bool IsAlive { get; set; }
        public bool IsProtected { get; set; }
        public int nightVotes = 0;
        public int dayVotes = 0;

        public Player(string name, Role role)
        {
            Name = name;
            Role = role;
            IsAlive = true;
            IsProtected = false;
            nightVotes = 0;
            dayVotes = 0;

        }
    }
    public class WerewolfGame
    {
        public static List<Player> players;
        private int werewolvesAlive;
        private int villagersAlive;

        public WerewolfGame()
        {
            players = new List<Player>();
        }

        // Add player to the game
        public void AddPlayer(string name, Role role)
        {
            players.Add(new Player(name, role));
            UpdateAliveCounts();
        }

        // Assign roles randomly
        public void AssignRoles()
        {
            Random rand = new Random();
            var roles = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            roles.Remove(Role.Villager); // Only villagers are assigned by default

            // Randomly assign roles to players
            foreach (var player in players)
            {
                if (player.Role == Role.Villager && roles.Count > 0)
                {
                    int index = rand.Next(roles.Count);
                    player.Role = roles[index];
                    roles.RemoveAt(index);
                }
            }
        }

        // Update counts of alive players
        private void UpdateAliveCounts()
        {
            werewolvesAlive = players.Count(p => p.Role == Role.Werewolf && p.IsAlive);
            villagersAlive = players.Count(p => p.Role != Role.Werewolf && p.IsAlive);
        }

        // Simulate Night Phase 
        public void NightPhase()
        {
            foreach (var player in players)
            {
                if (player.Role == Role.Villager && player.IsAlive)
                {
                    MessageBox.Show("You are a villager");
                }
                else if (player.Role == Role.Werewolf && player.IsAlive)
                {
                    MessageBox.Show($"{player.Name} is a werewolf");
                    WerewolfKillScreen werewolfKillScreen = new WerewolfKillScreen();
                    werewolfKillScreen.Show();

                }
                else if (player.Role == Role.Seer && player.IsAlive)
                {
                    MessageBox.Show($"{player.Name} is a seer");
                    SeerScreen seerScreen = new SeerScreen();
                    seerScreen.Show();

                }
                else if (player.Role == Role.Doctor && player.IsAlive)
                {
                    MessageBox.Show($"{player.Name} is a doctor");
                    DoctorScreen doctorScreen = new DoctorScreen();
                    doctorScreen.Show();

                }
                else if (player.Role == Role.Veteran && player.IsAlive)
                {
                    MessageBox.Show($"{player.Name} is a veteran");
                    VeteranScreen veteranScreen = new VeteranScreen();
                    veteranScreen.Show();

                }
                else if (player.Role == Role.Witch && player.IsAlive)
                {
                    MessageBox.Show($"{player.Name} is a witch");
                    WitchScreen witchScreen = new WitchScreen();
                    witchScreen.Show();

                }
                else if (player.Role == Role.Jester && player.IsAlive)
                {
                    MessageBox.Show($"{player.Name} is a jester");
                }
            }
            if (IsGameOver() == false)
                DayPhase();

            else
            {
                MessageBox.Show("Game Over");
            }


        }


        // Simulate Day Phase (Voting to eliminate a suspect)
        public void DayPhase()
        {
            var alivePlayers = players.Where(p => p.IsAlive).Select(p => p.Name).ToList();
            VotingScreen votingScreen = new VotingScreen(alivePlayers);
            votingScreen.Show();
            if (IsGameOver() == false)
                NightPhase();
            else
            {
                MessageBox.Show("Game Over");
            }
        }

        public bool IsGameOver()
        {
            if (werewolvesAlive == 0)
            {
                MessageBox.Show("Villagers Win!");
                return true;
            }
            else if (werewolvesAlive >= villagersAlive)
            {
                MessageBox.Show("Werewolves Win!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}





