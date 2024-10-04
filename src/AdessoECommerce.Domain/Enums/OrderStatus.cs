namespace AdessoECommerce.Domain.Enums;

public enum OrderStatus
{
    Pending, // Beklemede
    Approved, // Onaylandı
    Cancelled, // İptal edildi
    Preparing, // Hazırlanıyor
    Shipped, // Kargoya verildi
    Delivered, // Teslim edildi
}