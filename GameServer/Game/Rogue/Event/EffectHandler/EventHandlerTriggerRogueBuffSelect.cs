﻿using EggLink.DanhengServer.Enums.Rogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Game.Rogue.Event.EffectHandler
{
    [RogueEvent(DialogueEventTypeEnum.TriggerRogueBuffSelect)]
    public class EventHandlerTriggerRogueBuffSelect : RogueEventEffectHandler
    {
        public override void Handle(RogueInstance rogue, RogueEventInstance? eventInstance, List<int> ParamList)
        {
            rogue.RollBuff(ParamList[2], ParamList[0], ParamList[1]);
        }
    }
}
