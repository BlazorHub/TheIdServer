﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aguacongas.IdentityServer.Store.Entity
{
    public class ApiScope : IAuditable
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        [MaxLength(200)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ApiScope{TKey}"/> is required.
        /// </summary>
        /// <value>
        ///   <c>true</c> if required; otherwise, <c>false</c>.
        /// </value>
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ApiScope{TKey}"/> is emphasize.
        /// </summary>
        /// <value>
        ///   <c>true</c> if emphasize; otherwise, <c>false</c>.
        /// </value>
        public bool Emphasize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show in discovery document].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show in discovery document]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowInDiscoveryDocument { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the modified at.
        /// </summary>
        /// <value>
        /// The modified at.
        /// </value>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets the API.
        /// </summary>
        /// <value>
        /// The API.
        /// </value>
        public virtual Api Api { get; set; }

        /// <summary>
        /// Gets or sets the API scope claims.
        /// </summary>
        /// <value>
        /// The API scope claims.
        /// </value>
        public virtual ICollection<ApiScopeClaim> ApiScopeClaims { get; set; }


    }
}
