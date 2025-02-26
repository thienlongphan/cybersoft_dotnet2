window.scrollToTop = () => {
  window.scrollTo({
    top: 0,
    behavior: "smooth",
  });
};

function showFeedbackModal() {
  console.log("FeebackModel");
  const feedbackModal = new bootstrap.modal(
    document.getElementById("feedbackModal"),
    {}
  );
  feedbackModal.show();
}
