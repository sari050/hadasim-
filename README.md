# hadasim- תרגיל בית- הדסים
חלק ב':
#1 
השאלות הנוספות אותם ההיתי שואלת הם:
*מה קורה אם אחד האנשים שנמצאים יחד בבידוד, מחלים לפני כולם וצריך כבר לסיים
איך זה מתעדכן?!
* האם יש הגבלה למספר האנשים שניתן לכלול בבידוד קבוצתי אם כן, מה הגבול?
*מה קורה אם בן אדם היה באותו חדר\ מקום עם החולה, אבל לא היה איתו במגע ישיר
*צריך שכל אחד שחייב בידוד יקבל לטלפון שלו התראה כדי שיידע שעליו להכנס לבידוד
*צריך לאפשר\לא לאפשר גישה לביטול או שינוי בקשת בידוד קבוצתית, לאחר השליחה
*מה יקרה כאשר יכניסו נתונים לא חוקיים, לא נכונים או חסרים (תאריך שגוי, שם בדוי וכו)
*כיצד תתנהל המערכת עם מספר רב של דרישות והרבה בקשות ולא תקרוס ותבלבל נתונים
*תוך כמה זמן מגילוי החולי צריך להגיש בקשה וממתי הבקשה נהפכת ל-לא רלוונטית,
איך תתנהל המערכת אם יגישו בקשה במועד לא רלוונטי-חורג
* האם יש הגבלות על הנתונים הגיאוגרפיים שניתן לבחור (למשל חייב להיות ברדיוס מסוים)?
* האם יש טיפול בשגיאות עבור קלט לא חוקי או שגיאות שרת? אם כן, מהי ההתנהגות הצפויה?
* האם יש שיקולי אבטחה כלשהם לטיפול בנתונים אישיים (למשל מספרי טלפון)? אם כן, אילו אמצעים ננקטים כדי להגן על פרטיות המשתמש?
* האם יש הגבלות כלשהן על טווח התאריכים עבור תאריך החשיפה ותאריך ההחלמה (למשל חייב להיות בתוך מסגרת זמן מסוימת)?
#2
מסמך בדיקה עבור הפיצ'ר:
דבר ראשון נעשה בדיקות בצד שרת: 
*נבדוק שהשרת מטפל נכון במקרי קצה לדוג'
-נתוני מיקום לא חוקיים\לא קיימים
-טווח תאריכים ל חוקי לדוג, תאריך התאוששות לפני תאריך החשיפה
-אם המערך של האנשים ריק
-מערך גדול (מידי) של אנשים צריך לבדוק כדי לוודא שהשרת יכול להתמודד עם בקשות גדולות
*נבדוק שבבקשה עם שדה חסר אכן מחזירה סטטוס 400
*נבדוק שבקשה חוקית מהשרת מחזירה סטטוס 201
*נבדוק שהשרת מטפל נכון בקלט לא חוקי, לדוג' בשדה תאריך הקלט אינו תאריך 
*נבדוק מה קורה כשיש עומס על השרת, נבדוק שהשרת מגיב נכון ומתמודד עם כמויות רבות של נתונים ובקשות
*נבדוק שהשרת מחזיר תשובות ותגובות כראוי
*נבדוק על סביבות עבודה ופלטפורמות שונות שהשרת עובד עליהם כמו שצריך
*נבדוק לגבי אזורי זמן שונים, שהשרת מתמודד בצורה נכונה עם המרת השעות
*
בדיקות בצד לקוח:
*נבדוק שממשק המשתמש מציג הודעה קופצת כאשר לא נבחר מיקום\תאריך
*נבדוק שצד הלקוח מציג את רכיב המפה של גוגל בצורה טובה ויפה
*נבדוק שממשק המשתמש קולט את קלט המשתמש ושולח לשרת כראוי
*נבדוק עם מכשירים ודפדפנים שונים כדי לוודא שה UI מגיב ועובד טוב בכל סוגי הפלטפורמות
*נבדוק בגדלי מסך שונים האם ממשק המשתמש מוצג עדין בצורה נכונה!?...
*נבדוק את צד ההרשאות, כדי להבטיח לעצמנו שממשק המשתמש מגביל גישה לתכונות מסוימות ונתונים מסוימים
*נבדוק עם רמות שונות של היכרות עם המערכת, שהUI  שלה מתאים למנוסים ומתחילים כאחד
*נבדוק את כל רמות צרכי הנגישות של המשתמשים כדי לוודא שהUI נגיש (לדוג ליקויי ראיה\שמיעה

נעזרתי מעט בCHAT GPT
