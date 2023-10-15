using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class LoaiSp
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
