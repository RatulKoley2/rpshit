namespace FivemShit.API.Endpoints
{
    public static class UserEndpoints
    {
        public static WebApplication StaffMasterEndpoint(this WebApplication app)
        {
            app.MapPost("Staff/GetStaffById", [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "5")]
            async ([FromBody] StaffViewModel objModel, IStaffService staffservice) =>
            {
                return Results.Ok(await staffservice.GetStaffById(objModel));
            }).WithTags("Staff Master");
            return app;
        }
    }
}
