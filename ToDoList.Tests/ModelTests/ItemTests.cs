using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;
using System.Collections.Generic;

namespace ToDoList.Tests 
{
    [TestClass]
    public class ItemTest: IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }
        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item() {
            Item newItem = new Item("test");
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string result = newItem.Description;
            Assert.AreEqual(description, result);
        }
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //arrange
            string description = "Walk the dog.";
            Item newItem = new Item(description);

            //act
            string updatedDescription = "Do the dishes";
            newItem.Description = updatedDescription;
            string result = newItem.Description;

            //assert
            Assert.AreEqual(updatedDescription, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            //arrange
            List<Item> newList = new List<Item> {};
            //act 
            List<Item> result = Item.GetAll();
            //assert
            CollectionAssert.AreEqual(newList, result);
                
        }
        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
            //arrange
            string description1 = "Walk the dog.";
            string description2 = "Do the dishes";
            Item newItem1 = new Item(description1);
            Item newItem2 = new Item(description2);
            List<Item> newList = new List<Item> {newItem1, newItem2};

            //act
            List<Item> result = Item.GetAll();

            //assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}