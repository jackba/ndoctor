﻿/*
    This file is part of NDoctor.

    NDoctor is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    NDoctor is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with NDoctor.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace Probel.NDoctor.Domain.DTO.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    using Probel.Helpers.Strings;
    using Probel.NDoctor.Domain.DTO.Properties;

    /// <summary>
    /// The exception that is thrown when the searched item doesn't exist in the database
    /// </summary>
    [Serializable]
    public class EntityNotFoundException : ApplicationException
    {
        #region Constructors

        public EntityNotFoundException(Type searchedType)
            : this(Messages.Ex_EntityNotFoundException.FormatWith(searchedType.Name))
        {
        }

        public EntityNotFoundException(string message)
            : base(message)
        {
        }

        public EntityNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public EntityNotFoundException(Type searchedType, Exception inner)
            : this(Messages.Ex_EntityNotFoundException.FormatWith(searchedType.Name), inner)
        {
        }

        protected EntityNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion Constructors
    }
}