   M S B A M L   `   `   `  ????  DormitoryManagement3    -DormitoryManagement.Windows.WindowExpireRooms   5   	   W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      -   5          ? Title$  WindowExpireRooms??5      $
??Auto??6   $
??Auto??6-    ? 
ResizeMode$ NoResize=?6:   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5
   
   ?? $??139,12,140,0q?6   $	??Top=?6*   $??39??6B   $&?? Các Phòng Cần Ghi Hóa Đơn??6N   $
??Wrap=?6o   ???	#FF116A98$??16(?6?   $
??Bold"?6?    ?? TextAlignment$ Center=?6?   $??0??6?   ?? 5   
   -   5        $??
lvRoomList??5   7    ?? SelectionMode$ Single=?6   $??1??6*   $??Right=?6I   $??Center=?6l   $	??518??6?    ?? View 5      ?? 5      .P?5      ?? $??
Mã Phòng??6%    ?? Width$ 80??67    ?? DisplayMemberBinding 6B   ?? *RoomID+?? 5      $??Tên Phòng??6%   $	 100??68    6D   ?? *Name+?? 5      $??Ngày đến??6%   $	 120??67    6C   ?? *
ComingDate+?? 5      $??Số Điện??6%   $	 120??66    6B   ?? *
ElectricNo+?? 5      $??Số Nước??6%   $	 120??66    6B   ?? *	WaterNo+5      5      5      5      