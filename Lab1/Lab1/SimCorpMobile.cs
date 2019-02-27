using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Lab1 {
    public class SimCorpMobile : Mobile {
        public override ScreenAttribute Screen {
            get {
                return vScreen;
            }
        }

        private readonly MultyTouchScreen vScreen = new MultyTouchScreen();

        public override KeyboardAttribute Keyboard {
            get {
                return vKeyboard;
            } 
        }

        private readonly OnScreenKeyboard vKeyboard = new OnScreenKeyboard();

        public override BatteryAttribute Battery {
            get {
                return vBattery;
            }
        }

        private readonly LithiumIonBattery vBattery = new LithiumIonBattery();

        public override SlotAttribute Slot {
            get {
                return vSlot;
            }
        }

        private readonly SimCardSlot vSlot = new SimCardSlot();
    }
}
