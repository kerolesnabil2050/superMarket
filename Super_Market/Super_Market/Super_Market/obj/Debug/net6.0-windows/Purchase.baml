   M S B A M L   `   `   `  ????G  CSuper_Market, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Super_MarketSuper_Market  5          Super_Market.Purchase   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Super_Market     5      .??5
      (? .??5   
   ??   ?? CornerRadius$  35??6    ?? Padding$ 40q?6#   
??????? J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 1Q?6#      
BlurRadius$ 20Q?63      Opacity$	 0.4Q?6C   6S   ._?5      ? $
??1100??6   $	??900??6     ? ColumnDefinitions 5      ?? 5      6)   ?? 5      6)    ? RowDefinitions 5      ?? 5      $	??130 ?6$   63   ?? 5      $	??190 ?6$   63   ?? 5      $	??440 ?6$   63   ?? 5      $??55 ?6$   62   ?? 5      $??85 ?6$   62   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $??30(?6   .??6*   
Suppliers:66   ?? 5      $??20(?6   $	??250??6.   $	??Top=?6:   ???	#FF5ABA9A$??15q?6i   6w   5      ?? 5      $??1??6   $ 
Horizontal=?6-   .+?5       ?? $??30(?6   .??6*   Store:62   ?? 5!      $??20(?6   $	??250??6.   $	??Top=?6:   ???	#FF5ABA9A$??15q?6i   6w   5"      ?? 5#      $ 
Horizontal=?6   $??0 60 0 0q?66   .+?5$      ?? $??30(?6   .??6*   Date:61   ?? 5%      $??20(?6   $	??250??6.   $	??Top=?6:   ???	#FF5ABA9A$??	70 12 0 0q?6i   6~   5&      ? 5(      $??1??6   $??2??6$    5)      ?? 5*      6-   ?? 5+      6.   ?? 5,      6-   .+?5/      ?? .+?50      ?? $??30(?6    .??6.   
Product:68   ?? 51      $
??Left=?6#   $	??Top=?6?   $??30(?6W   ???	#FF5ABA9A$	??250??6|   	 ?? 
IsEditable$
	 True??6?   
 ?? Text$
 Choose Product??6?   6?   52      ?? 53      $??1??6!   .+?54      ?? $??30(?6    .??6.   	Quantity:69   ?? 55      $
??Left=?6"   $	??150??6=   $??30(?6I   ???	#FF5ABA9A.??6o   06r   56      ?? 57      $??2??6!   .+?58      ?? $??30(?6    .??6.   Price:66   ?? 59      $
??Left=?6"   $??30(?6=   $	??200??6K   ???	#FF5ABA9A.??6p   0.006v   5:      5<      ?? 5=      $ 
Horizontal=?6   $??1??66   $??2??6C   $??Bottom=?6W   $??Center=?6r   .+?5>      ?? $	??150??6   $??50??6)   $??15q?65   $??28(?6A   .??6O   Add6T   ?? 5?      $	??150??6   $??50??6)   $??15q?65   $??28(?6A   .??6O   Save6U   ?? 5@      $	??150??6   $??50??6)   $??15q?65   $??28(?6A   .??6O   Delete6W   5A      ?? 5C      $??2??6   $??2??6*   $ 
Horizontal=?6>   $	??400??6W   $	??Top=?6e   $??Center=?6}   $??0,40,0,0q?6?   .+?5D      &   System.Windows.Controls.DataGrid  -   5          Name$ datagrid??5D      $	??402??63   $
??1100??6@   $??0 0 0 30q?6M    ? 	Resources 5E      =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%?   '        ?? 5F      "  6$   .?5G   "   ??  ? ?? ?	#FF5ABA9A6?   ?? 5H   "    ? ??$ SemiBold"?6?   ?? 5I   "    ? ??$ 30(?6=   ?? 5K   "    ? ??$ 0,0,1,2q?6D   5M      5N         Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ Product??61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 500 6B     5Q      $ Quantity??61   $	 250 6C     5R      $ Purchase Price??61   $	 250 6I   5U      5V      ? 5X      $??3??6   $??2??6$   $
??Left=?68   .+?5Y      ?? $ 
Horizontal=?6!   $
??1100??6:   $??0 10 0 0q?6G   .+?5Z      ?? $ 
Horizontal=?6%   $	??405??6>   .+?5[      ?? $??30(?6$   .??62   Total Price:6@   ?? 5\      $??30(?6$   .??62   0.0068   5]      ?? 5^      $ 
Horizontal=?6%   $	??300??6>   .+?5_      ?? $??30(?6$   .??62   Paid Money:6?   ?? 5`      $??30(?6&   .??64   0.006:   5a      ?? 5b      $ 
Horizontal=?6%   $	??410??6>   .+?5c      ?? $??30(?6$   .??62   Remaining Money:6D   ?? 5d      $??30(?6$   .??62   0.0068   5e      5g      5h      ? 5j      $??4??6   $??2??6$   .+?5k      ?? $ 
Horizontal=?6!   $??1??6:   $??2??6G   $??Bottom=?6[   $??Center=?6v   .+?5l      ?? $	??250??6!   $??50??6-   $??15q?69   $??28(?6E   .??6S   New Process6`   ?? 5m      $	??250??6!   $??50??6-   $??15q?69   $??28(?6E   .??6S   Save Process6a   ?? 5n      $	??250??6!   $??50??6-   $??15q?69   $??28(?6E   .??6S   Delete Process6c   5o      5p      5r      5s      5t      5u      