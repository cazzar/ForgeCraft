﻿/*
	Copyright 2011 ForgeCraft team
	
	Dual-licensed under the	Educational Community License, Version 2.0 and
	the GNU General Public License, Version 3 (the "Licenses"); you may
	not use this file except in compliance with the Licenses. You may
	obtain a copy of the Licenses at
	
	http://www.opensource.org/licenses/ecl2.php
	http://www.gnu.org/licenses/gpl-3.0.html
	
	Unless required by applicable law or agreed to in writing,
	software distributed under the Licenses are distributed on an "AS IS"
	BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
	or implied. See the Licenses for the specific language governing
	permissions and limitations under the Licenses.
*/
using System;
using System.Collections.Generic;

namespace SMP.Commands
{
    public class CmdDemote : Command
    {
        public override string Name { get { return "demote"; } }
        public override List<string> Shortcuts { get { return new List<string> { "" }; } }
        public override string Category { get { return "permissions"; } }
        public override bool ConsoleUseable { get { return false; } }
        public override string Description { get { return "demotes a player"; } }
        public override string PermissionNode { get { return "core.permissions.demote"; } }

        public override void Use(Player p, params string[] args)
        {
            if (args.Length == 0)
            {
                Help(p);
                return;
            }

            Player pr = Player.FindPlayer(args[0]);
            if (pr == null)
            {
                p.SendMessage(HelpBot + "Could not find player.");
                return;
            }
            if (pr == p)
            {
                p.SendMessage(HelpBot + "You can't demote yourself.");
                return;
            }
            if (GroupUtils.DemotePlayer(pr))
            {
                p.SendMessage(HelpBot + "Player demoted.");
                pr.SendMessage(HelpBot + p.username + " demoted you.");
            }
            else
                p.SendMessage(HelpBot + "Could not demote player");
        }
        public override void Help(Player p)
        {
            p.SendMessage("/demote <player> - Demotes the player");
        }
    }
}