   M S B A M L   `   `   `  ����  
Mobile APP    Mobile_APP.GravarVoz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          �Name$  _mainWindow��5       � Title$ JARVIS��5   	   $��5,5,5,5q�6   $	��800��6)   .��5      � $��5q�6    � RowDefinitions 5   
   �� 5	      $
��auto �6   �� 5
      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��200��6)   �� 5      $��* �6   $	��200��6)   .+�5   
   �� $��0��6   $��0��6   $
��Left=�6-   $��JARVIS Speech Recognition��6H   � 5   
   $��0��6   $��1��6   $��0,0,10,0q�6,   � 5   
   $��1��6   $��0��6    5      �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $
��auto �6    .+�5      �� -   5         ��Name$ _radioGroup��5      $��0��6,   $��10,10,10,10q�69   $��0, 0, 10, 10q�6N   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �� $ ��Speech Recognition Source:��6   	� 5      -   5         	�Name$ _micRadioButton��5   "   $��10, 10, 0, 0q�6�   $*��$Use Microphone with ShortPhrase mode��6�    d� 	IsChecked 6;   �� *IsMicrophoneClientShortPhrase+ �� ElementName$ _mainWindow��6�   	� 5      -   5        $ _micDictationRadioButton��5   "   $��10, 10, 0, 0q�6�   $,��&Use Microphone with LongDictation mode��6�    6D   �� *IsMicrophoneClientDictation+$ _mainWindow��6�   	� 5      -   5        $ _dataShortRadioButton��5   "   $��10, 10, 0, 0q�6�   $'��!Use wav file for ShortPhrase mode��6�    6A   �� *IsDataClientShortPhrase+$ _mainWindow��6�   	� 5       -   5        $ _dataLongRadioButton��5    "   $��10, 10, 0, 0q�6�   $)��#Use wav file for LongDictation mode��6�    6@   �� *IsDataClientDictation+$ _mainWindow��6�   5"      5#      � 5$      $��2��6   $��10, 0, 10, 10q�6     5%      �� 5&      $
��auto �6'   �� 5'      $
��auto �6'   .+�5)      �� -   5        	 ��Name$	 _startButton��5)      $��0��6/   $��Start _Recognition��6?   $��5q�6v   $��5q�6�   5*      �� 5+      -   5        
 ��Name$
 textBox��5+      $
��Left=�6'   $��27��6B   $��0,10,0,0q�6N   $��1��6`    �� TextWrapping$
 Wrap=�6m   $��File_name.txt��6�   $	��Top=�6�   $	��105��6�   6�   �� 5,      -	   5        $	 
CreateFile��5,      $��
CreateFile��6)   $
��Left=�6>   $��27��6Y   $��
132,10,0,0q�6e   $��1��6y   $	��Top=�6�   $��57��6�    J� RenderTransformOrigin$ -0.075,0.736&�6�   6�   5-      �� 5.   
   -
   5        $
 _logText��5.      $��1��6$   $��1��61   $��Stretch=�6A   $��Stretch=�6_   $
 Wrap=�6{   $�� ��6�   " �� VerticalScrollBarVisibility$ Visible=�6�   $��0, 10, 10, 10q�6�   5/      50      