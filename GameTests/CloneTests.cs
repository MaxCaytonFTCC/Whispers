using GameWorldLibrary;

namespace GameTests
{
    [TestClass]
    public class CloneTests
    {
        [TestMethod]
        public void TestItemClone()
        {
            // Create base item and clone item
            Item base_item = new Item(0, "Test Item", 10, false, false, "Test Item Description", UsableType.Item);
            Item clone_item = new Item(base_item);
            bool isSame;

            // Compare properties
            isSame = (base_item.ID == clone_item.ID) ? true : false;
            isSame = (base_item.Name == clone_item.Name && isSame) ? true : false;
            isSame = (base_item.Price == clone_item.Price && isSame) ? true : false;
            isSame = (base_item.QuestItem == clone_item.QuestItem && isSame) ? true : false;
            isSame = (base_item.Required == clone_item.Required && isSame) ? true : false;
            isSame = (base_item.Description == clone_item.Description && isSame) ? true : false;
            isSame = (base_item.Type == clone_item.Type && isSame) ? true : false;

            // Check if items are equal but different instances
            Assert.IsTrue(isSame, "Item properties are not the same");  // Check if different properties
            Assert.AreNotSame(base_item, clone_item, "Item Objects are the same reference");  // Check if different instance
        }

        [TestMethod]
        public void TestPotionClone()
        {
            // Create base potion and clone potion
            Potion base_potion = new Potion(0, "Test Potion", 10, false, false, 15, "Test Potion Description", UsableType.Potion);
            Potion clone_potion = new Potion(base_potion);
            bool isSame;

            // Compare properties
            isSame = (base_potion.ID == clone_potion.ID) ? true : false;
            isSame = (base_potion.Name == clone_potion.Name && isSame) ? true : false;
            isSame = (base_potion.Price == clone_potion.Price && isSame) ? true : false;
            isSame = (base_potion.QuestItem == clone_potion.QuestItem && isSame) ? true : false;
            isSame = (base_potion.Required == clone_potion.Required && isSame) ? true : false;
            isSame = (base_potion.ValueChange == clone_potion.ValueChange && isSame) ? true : false;
            isSame = (base_potion.Description == clone_potion.Description && isSame) ? true : false;
            isSame = (base_potion.Type == clone_potion.Type && isSame) ? true : false;

            // Check if potions are equal but different instances
            Assert.IsTrue(isSame, "Potion properties are not the same");    // Check if different properties
            Assert.AreNotSame(base_potion, clone_potion, "Potion Objects are the same reference");  // Check if different instance
        }

        [TestMethod]
        public void TestWeaponClone()
        {
            // Create base weapon and clone weapon
            Weapon base_weapon = new Weapon(0, "Test Weapon", "Test Weapon Description", "Blunt", 15, false, true, 5, UsableType.Weapon);
            Weapon clone_weapon = new Weapon(base_weapon);
            bool isSame;

            // Compare properties
            isSame = (base_weapon.ID == clone_weapon.ID) ? true : false;
            isSame = (base_weapon.Name == clone_weapon.Name && isSame) ? true : false;
            isSame = (base_weapon.Description == clone_weapon.Description && isSame) ? true : false;
            isSame = (base_weapon.DamageType == clone_weapon.DamageType && isSame) ? true : false;
            isSame = (base_weapon.Price == clone_weapon.Price && isSame) ? true : false;
            isSame = (base_weapon.QuestItem == clone_weapon.QuestItem && isSame) ? true : false;
            isSame = (base_weapon.Required == clone_weapon.Required && isSame) ? true : false;
            isSame = (base_weapon.Damage == clone_weapon.Damage && isSame) ? true : false;
            isSame = (base_weapon.Type == clone_weapon.Type && isSame) ? true : false;

            // Check if weapons are equal but different instances
            Assert.IsTrue(isSame, "Weapon properties are not the same");    // Check if different properties
            Assert.AreNotSame(base_weapon, clone_weapon, "Weapon Objects are the same reference");  // Check if different instance
        }

        [TestMethod]
        public void TestTreasureClone()
        {
            // Create base treasure and clone treasure
            Treasure base_treasure = new Treasure(0, "Test Treasure", 50, true, false, "Test Treasure Description", UsableType.Treasure);
            Treasure clone_treasure = new Treasure(base_treasure);
            bool isSame;

            // Compare properties
            isSame = (base_treasure.ID == clone_treasure.ID) ? true : false;
            isSame = (base_treasure.Name == clone_treasure.Name && isSame) ? true : false;
            isSame = (base_treasure.Price == clone_treasure.Price && isSame) ? true : false;
            isSame = (base_treasure.QuestItem == clone_treasure.QuestItem && isSame) ? true : false;
            isSame = (base_treasure.Required == clone_treasure.Required && isSame) ? true : false;
            isSame = (base_treasure.Description == clone_treasure.Description && isSame) ? true : false;
            isSame = (base_treasure.Type == clone_treasure.Type && isSame) ? true : false;

            // Check if treasures are equal but different instances
            Assert.IsTrue(isSame, "Treasure properties are not the same");  // Check if different properties
            Assert.AreNotSame(base_treasure, clone_treasure, "Treasure Objects are the same reference");  // Check if different instance
        }
    }
}
