namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        public int Id { get; set; }
        public int USerId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
