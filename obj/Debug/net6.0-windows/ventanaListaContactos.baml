   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	   #    WpfApp2.ventanaListaContactos   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  ventanaListaContactos��5   	   $	��450��6'   $	��800��64   .��5	      �� .+�5
   
   �� -   5         ��Name$ 
barraBusca��5
      $��30��6K   $��
23,21,23,0q�6W   
�������$��2q�6~   6�   �� 5   
   -   5         ��Name$ lista��5      $��20q�6"    �� View 5      �� 5      .P�5      �� $��Nombre��6%    �� Width$
 auto��65    �� DisplayMemberBinding 6B   �� *nombre+�� 5      $
��Mail��6%   $
 auto��63    6@   �� *mail+�� 5      $��Telefono��6%   $
 auto��67    6D   �� *
telefono+5      5      �� 5   
   -   5         ��Name$ bloqueResultados��5      
����  �$��20��6@    �� Padding$	 5,0q�6L   
�������$
��20,5q�6m   6}   5      5      