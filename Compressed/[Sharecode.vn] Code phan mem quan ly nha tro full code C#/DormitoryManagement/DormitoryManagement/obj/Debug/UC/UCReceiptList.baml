   M S B A M L   `   `   `  ????  DormitoryManagement*    $DormitoryManagement.UC.UCReceiptList   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5        $
??Auto??5      $
??Auto??6   .??5      ?? $
??Auto=?6   .??5   
   ?   ? RowDefinitions  5      ?? 5      $
??Auto ?6    ?? 5	      $
??Auto ?6    ?? 5
      $
??Auto ?6    .+?5      ?? $??16(?6   $
??Bold"?6&   ???	#FF116A98$??39??6O   $??157,23,157,0q?6[   $??Danh Sách Hóa Đơn??6q    ?? TextAlignment$ Center=?6?   $
??Wrap=?6?   $	??Top=?6?   $??0??6?   ?? 5      -   5        $??lvReceiptList??5   M   $??Right=?6   $??	0,22,0,29q?6:    ?? SelectionMode$ Single=?6b   $??1??6y    ?? View 5      ?? 5      .P?5      ??  ?? Width$ 80??6T    ?? DisplayMemberBinding 6)   ?? *	ReceiptID+.??6_   Mã Hóa Đơn6k   ?? 5      $ 80??6O    6)   ?? *Name+.??6Z   Tên Phòng6e   ?? 5      $	 100??6R    6)   ?? *	RoomFee+.??6^   Tiền Phòng6j   ?? 5      $ 80??6V    6)   ?? *ElectricFee+.??6a   Tiền Điện6l   ?? 5      $ 80??6S    6)   ?? *
WaterFee+.??6^   Tiền Nước6i   ?? 5      $ 80??6S    6)   ?? *
OtherFee+.??6^   Chi Phí Khác6l   ?? 5      $ 80??6P    6)   ?? *Total+.??6[   Tổng Cộng6f   ?? 5      $ 80??6O    6)   ?? *Debt+.??6Z   Nợ6^   ?? 5      $
 Auto??6U    6)   ?? *
StatusName+.??6b   Trạng Thái6n   ?? 5      $
 Auto??6O    6)   ?? *Date+.??6\   Tháng6c   ?? 5      $
 Auto??6O    6)   ?? *Note+.??6\   
Ghi chú6e   5      5      ?? 5      $??
94,0,93,23q?6   $ Center=?6,   $??46??6C   $??Bottom=?6O   $??2??6j   ?? 5      -   5        $??btAddReceipt??5   D   $??30??68   $	??101??6X   .??6d   Thêm Hóa Đơn6r    ?? 5       -   5        $??btEditReceipt??5    E   $??30??69   $	??150??6Z   .??6f   Thay đổi Hóa Đơn6x    ?? 5!      -   5        $??btDeleteReceipt??5!   G   $??30??6;   $	??100??6^   .??6j   Hủy Hóa Đơn6w   5"      5#      5$      5%      