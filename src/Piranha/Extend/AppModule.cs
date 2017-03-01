﻿/*
 * Copyright (c) 2016-2017 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * https://github.com/piranhacms/piranha.core
 * 
 */

namespace Piranha.Extend
{
    public sealed class AppModule : AppDataItem
    {
        /// <summary>
        /// Gets/sets the module instance.
        /// </summary>
        public IModule Instance { get; set; }
    }
}
