import cv2

cap = cv2.VideoCapture("D:\Downloads\Project Video.mp4")

while cap.isOpened():
    ret, frame = cap.read()
    if not ret:
        break

    gray_frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    blurred_frame = cv2.GaussianBlur(gray_frame, (1, 1), 0)

    thresholded_frame = cv2.adaptiveThreshold(blurred_frame, 255, cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY_INV, 11, 4)

    contours, _ = cv2.findContours(thresholded_frame, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)

    # Group contours to form words
    words = []
    letters =[]
    for contour in contours:
        x, y, w, h = cv2.boundingRect(contour)
        area = cv2.contourArea(contour)

        min_area = 100
        max_area = 700
        
        if min_area < area < max_area and y > 600 :

            cv2.rectangle(frame, (x, y), (x+w, y+h), (0, 255, 0), 2)
            words.append((x, y, x + w, y + h))


    merged_line = []
    for word in sorted(words, key=lambda x: x[0]):
        if not merged_line:
            merged_line.append(word)
        else:
            prev_x_min, _, prev_x_max, _ = merged_line[-1]
            curr_x_min, _, curr_x_max, _ = word
            if curr_x_min - prev_x_max < 80:  
                merged_line[-1] = (prev_x_min, min(merged_line[-1][1], word[1]), curr_x_max, max(merged_line[-1][3], word[3]))
            else:
                merged_line.append(word)

            
    


                

    # Draw rectangles around words
    for word in merged_line:
        x_min, y_min, x_max, y_max = word
        cv2.rectangle(frame, (x_min, y_min), (x_max, y_max), (0, 0, 255), 2)

    cv2.imshow('Subtitle Detection', frame)

    if cv2.waitKey(25) & 0xFF == ord('q'):
        break

cap.release()
cv2.destroyAllWindows()
