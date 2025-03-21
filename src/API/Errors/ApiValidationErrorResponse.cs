namespace API.Errors
{
    public class ApiValidaationErrorResponse : ApiResponse
    {
        public ApiValidaationErrorResponse() : base(400)
        {

        }

        public IEnumerable<string> Errors { get; set; }
    }
}