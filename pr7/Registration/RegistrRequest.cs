using System;
using System.Collections.Generic;
using System.Text;

namespace pr7.Registration
{
    public record RegistrRequest
    (
        string Name,
        string Email,
        string Number,
        string Password
    );
}
