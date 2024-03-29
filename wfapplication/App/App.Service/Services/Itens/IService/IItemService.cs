﻿using App.Domain.Models.Itens;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Itens.IService
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> Get();

        Task<Item> Get(uint Id);

        Task<uint> Insert(Item Item);

        Task<bool> Update(Item Item);

        Task<bool> Delete(uint Id);
    }
}