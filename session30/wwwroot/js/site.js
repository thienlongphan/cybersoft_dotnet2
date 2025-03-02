window.scrollToTop = () => {
  window.scrollTo({
    top: 0,
    behavior: "smooth",
  });
};

function showFeedbackModal(feedbackModal) {
  console.log("FeebackModel", feedbackModal);
  var feedbackModal = new bootstrap.Modal(
    document.getElementById("feedbackModal")
  );
  feedbackModal.show();
}
