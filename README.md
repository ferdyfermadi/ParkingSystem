# Sistem Parkir Berbasis Konsol

Sistem parkir berbasis konsol ini dibangun menggunakan .NET 8 dengan bahasa pemrograman C#. Sistem ini menangani berbagai perintah untuk mengelola lot parkir, check-in dan check-out kendaraan, serta menghasilkan laporan tentang status lot parkir. Sistem ini mendukung kendaraan dengan tipe "Mobil Kecil" dan "Motor".

## Fitur

- **Membuat Lot Parkir**: Membuat tempat parkir dengan jumlah slot tertentu.
- **Check-in Kendaraan**: Menambahkan kendaraan ke dalam slot parkir yang tersedia.
- **Check-out Kendaraan**: Menghapus kendaraan dari slot parkir.
- **Menampilkan Status**: Menampilkan status saat ini dari semua slot parkir.
- **Laporan Berdasarkan Tipe Kendaraan**: Menampilkan jumlah kendaraan berdasarkan tipe.
- **Laporan Berdasarkan Nomor Polisi Ganjil dan Genap**: Menampilkan nomor kendaraan dengan plat ganjil atau genap.
- **Laporan Berdasarkan Warna Kendaraan**: Menampilkan jumlah kendaraan berdasarkan warna.
- **Pencarian Slot Berdasarkan Nomor Polisi**: Menampilkan slot kendaraan berdasarkan nomor polisi.
- **Pencarian Slot Berdasarkan Warna Kendaraan**: Menampilkan slot kendaraan berdasarkan warna.

## Cara Penggunaan

**Running code**
- .net run
  
**Jalankan pada console**
- **Membuat Lot Parkir**: create_parking_lot (slots), contoh : create_parking_lot 6
- **Check-in Kendaraan**: park (plate_license) (colour) (vehicles), contoh : park B-1234-XYZ Putih Mobil
- **Check-out Kendaraan**: leave (number_slots), contoh : leave 4
- **Menampilkan Status**: status
- **Laporan Berdasarkan Tipe Kendaraan**: type_of_vehicles (vehicles), contoh : type_of_vehicles Motor
- **Laporan Berdasarkan Nomor Polisi Ganjil dan Genap**: registration_numbers_for_vehicles_with_odd_plate dan registration_numbers_for_vehicles_with_even_plate
- **Laporan Berdasarkan Warna Kendaraan**: registration_numbers_for_vehicles_with_colour Putih
- **Pencarian Slot Berdasarkan Nomor Polisi**: slot_number_for_registration_number (plate_license), contoh : slot_number_for_registration_number B-3141-ZZZ
- **Pencarian Slot Berdasarkan Warna Kendaraan**: slot_numbers_for_vehicles_with_colour (colour), contoh : slot_numbers_for_vehicles_with_colour Putih
