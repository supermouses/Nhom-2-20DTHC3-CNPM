   M S B A M L   `   `   `  ????  DormitoryManagement(    "DormitoryManagement.UC.UCGuestList   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5        $
??Auto??5      $
??Auto??6   .??5      ?? $
??Auto=?6   .??5   
   ? .+?5      ?   ? RowDefinitions  5      ?? 5	      $
??Auto ?6$   ?? 5
      $
??Auto ?6$   ?? 5      $
??Auto ?6$   .+?5      ?? $??16(?6   $
??Bold"?6*   ???	#FF116A98$??234,7,234,4q?6S   $??Danh Sách Khách Trọ??6h    ?? TextAlignment$ Center=?6?   $
??Wrap=?6?   $??Center=?6?   ?? 5      -   5         ??Name$ lvGuestList??5   k   $??1??6   $
??Auto??6(   $??Right=?66   $??0,18,0,0q?6Y   $
??Auto=?6?    ?? SelectionMode$ Single=?6?   $	??Top=?6?    ?? View 5      ?? 5      .P?5      ??  ?? Width$ 80??6Q    ?? DisplayMemberBinding 6-   ?? *ID+.??6\   
Mã Khách6f   ?? 5      $	 200??6[    6-   ?? *CustomerName+.??6g   Tên Khách6r   ?? 5      $	 150??6Z    6-   ?? *MobilePhone+.??6f   
Di Động6o   ?? 5      $	 100??6S    6-   ?? *Name+.??6_   Phòng6f   ?? 5      $	 200??6S    6-   ?? *Note+.??6_   
Ghi Chú6h   5      5      ?? 5      $??2??6   $??94,24,93,23q?6)   $ Center=?6>   ?? 5      -   5        $??
btAddGuest??5   B   $??30??66   $	??101??6T   .??6`   Thêm Khách6l    ?? 5      -   5        $??btEditGuest??5   C   $??30??67   $	??150??6V   .??6b   Thay đổi thông tin Khách6|    ?? 5      -   5        $??btDeleteGuest??5   E   $??30??69   $	??100??6Z   .??6f   Xóa Khách6q   5      5      5      5       5!      