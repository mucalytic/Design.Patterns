using Design.Patterns.Mediator.Chat.Room.Concretions;
using Xunit.Abstractions;
using NSubstitute;

namespace Design.Patterns.Mediator.Chat.Room;

public class MediatorTests
{
    [Fact]
    public void AllUsersInChatRoom_ReceiveMessagesFromOtherUsers()
    {
        // arrange
        var helper = Substitute.For<ITestOutputHelper>();
        var chatRoom = new ChatRoom(helper);
        var bob = new RegularUser(helper, "Bob");
        var sue = new RegularUser(helper, "Sue");
        var jim = new RegularUser(helper, "Jim");
        var tom = new AdminUser(helper, "Tom");
        chatRoom.AddUser(bob);
        chatRoom.AddUser(sue);
        chatRoom.AddUser(jim);
        chatRoom.AddUser(tom);

        // act
        bob.Send("hello!");
        jim.Send("hi bob!");
        sue.Send("hello bob!");
        tom.Send("hello all!");

        // assert
        helper.Received(1).WriteLine("[Jim] Bob says: hello!");
        helper.Received(1).WriteLine("[Sue] Bob says: hello!");
        helper.Received(1).WriteLine("[Tom] Bob says: hello!");
        helper.Received(1).WriteLine("[Bob] Jim says: hi bob!");
        helper.Received(1).WriteLine("[Sue] Jim says: hi bob!");
        helper.Received(1).WriteLine("[Tom] Jim says: hi bob!");
        helper.Received(1).WriteLine("[Bob] Sue says: hello bob!");
        helper.Received(1).WriteLine("[Jim] Sue says: hello bob!");
        helper.Received(1).WriteLine("[Tom] Sue says: hello bob!");
        helper.Received(1).WriteLine("[Bob] Tom says: ADMIN MESSAGE! ## hello all! ##");
        helper.Received(1).WriteLine("[Jim] Tom says: ADMIN MESSAGE! ## hello all! ##");
        helper.Received(1).WriteLine("[Sue] Tom says: ADMIN MESSAGE! ## hello all! ##");
    }
}
