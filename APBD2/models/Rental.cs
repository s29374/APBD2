namespace APBD2.models;

public class Rental
{
    public Guid Id { get; }
    public User User { get; }
    public Device Device { get; }
    public DateTime RentDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }
    public decimal PenaltyAmount { get; private set; }
    public bool IsReturned => ReturnDate.HasValue;
    public bool IsOverdue => !IsReturned && DateTime.UtcNow > DueDate;
    public bool WasReturnedOnTime => ReturnDate.HasValue && ReturnDate.Value <= DueDate;

    public Rental(User user, Device device, DateTime rentDate, DateTime dueDate)
    {
        if (dueDate < rentDate)
        {
            throw new ArgumentException("Due date cannot be earlier than rent date.");
        }

        Id = Guid.NewGuid();
        User = user;
        Device = device;
        RentDate = rentDate;
        DueDate = dueDate;
    }

    public void CompleteReturn(DateTime returnDate, decimal penaltyAmount)
    {
        if (IsReturned)
        {
            throw new InvalidOperationException("Rental has already been returned.");
        }

        ReturnDate = returnDate;
        PenaltyAmount = penaltyAmount;
    }
}
