﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IPaymentValidationService
    {
        bool PayValidate(Game game);
    }
}