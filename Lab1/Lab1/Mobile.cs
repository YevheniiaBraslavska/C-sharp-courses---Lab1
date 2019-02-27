using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.Lab1 {
    public abstract class Mobile {
        private readonly ScreenAttribute vScreen;
        public abstract ScreenAttribute Screen {
            get;
        }

        private readonly KeyboardAttribute vKeyboard;
        public abstract KeyboardAttribute Keyboard {
            get;
        }

        private readonly BatteryAttribute vBattery;
        public abstract BatteryAttribute Battery {
            get;
        }

        private readonly SlotAttribute vSlot;
        public abstract SlotAttribute Slot {
            get;
        }

        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        public string GetDescription() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard Type: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Slot Type: {Slot.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}